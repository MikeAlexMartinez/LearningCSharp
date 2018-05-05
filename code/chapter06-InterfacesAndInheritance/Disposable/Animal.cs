using System;

namespace Disposable
{
    public class Animal : IDisposable
    {
        public Animal()
        {
            // allocate unmanaged resource
        }

        ~Animal() // Finalizer
        {
            if(disposed) return;
            Dispose(false);
        }

        bool disposed = false; // have resources been released

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // intenrnal overloaded function
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            // deallocate the *unmanaged* resource
            // ...
            if (disposing)
            {
                // deallocate any other *managed* resources
                // ...
            }
            disposed = true;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // code that removes Animal when finished
            // can do this when IDisposable is implemented
            using(Animal b = new Animal())
            {
                // code that uses animal isntance
            }

            // is compiled to
            Animal a = new Animal();
            try
            {
                // code that use the Animal Instance
            }
            // finally block runs after try (and catch)
            finally
            {
                if (a != null) a.Dispose();
            }

        }
    }
}

