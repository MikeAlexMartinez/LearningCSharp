namespace Packt.CS7
{
    [System.Flags]
    // More efficient to assign bytes as system flags instead of
    // internal ints. Allows us to combine choices.
    public enum WondersOfTheAncientWorld : byte
    {
        GreatPyramidOfGiza = 1,
        HangingGardensOfBabylon = 1 << 1,
        StatueOfZeusAtOlympia = 1 << 2,
        TempleOfArtemisAtEphesus = 1 << 3,
        MausoleumAtHalicarnassus = 1 << 4,
        ColossusOfRhodes = 1 << 5,
        LightouseOfAlexandria = 1 << 6
    }
}