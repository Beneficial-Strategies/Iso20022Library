// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a location and codified form.
    /// </summary>
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation))]
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation),nameof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation))]
    [JsonDerivedType(typeof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation),nameof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation))]
    #endif
    [IsoId("_97kuEnltEeG7BsjMvd1mEw_-1026438563")]
    [DisplayName("Place Or Under Confirmation Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlaceOrUnderConfirmationChoice1_
    #else
    public abstract partial class PlaceOrUnderConfirmationChoice1_
    #endif
    {
    }
}
