// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a location and codified form.
    /// </summary>
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation))]
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation))]
    [JsonDerivedType(typeof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation),nameof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation))]
    [JsonDerivedType(typeof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation),nameof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation))]
    [IsoId("_97kuEnltEeG7BsjMvd1mEw_-1026438563")]
    [DisplayName("Place Or Under Confirmation Choice")]
    public abstract partial record PlaceOrUnderConfirmationChoice1_
    {
    }
}
