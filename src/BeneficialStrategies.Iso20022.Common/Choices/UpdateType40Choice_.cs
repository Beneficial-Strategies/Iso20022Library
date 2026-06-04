// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.UpdateType40Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between addition, deletion, or modification of securities settlement transaction details.</summary>
    [IsoId("_Y5QzEZaMEfC2_67yGLymgA")]
    [DisplayName("Update Type 40 Choice")]
    [KnownType(typeof(UpdateType40Choice.Addition))]
    [KnownType(typeof(UpdateType40Choice.Deletion))]
    [KnownType(typeof(UpdateType40Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType40Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType40Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType40Choice.Modification))]
    public abstract record UpdateType40Choice_
    {
    }
}
