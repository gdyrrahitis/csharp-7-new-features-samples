namespace CSharpSeven.PatternMatching.SwitchCase
{
    using System;

    public class PatternMatching
    {
        public string MatchingMachineProduct(IMachine machine)
        {
            switch (machine)
            {
                case PizzaMachine pizzaMachine:
                    return pizzaMachine.Make();
                case FishAndChipsMachine fishAndChipsMachine:
                    return fishAndChipsMachine.Make();
                default:
                    return null;
                case null:
                    throw new ArgumentNullException(nameof(machine));
            }
        }
    }
}
