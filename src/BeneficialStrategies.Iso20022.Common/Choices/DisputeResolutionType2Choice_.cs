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
    /// Choice between a code or a proprietary code as to the nature of the dispute about the collateral amount.
    /// </summary>
    [KnownType(typeof(DisputeResolutionType2Choice.Code))]
    [KnownType(typeof(DisputeResolutionType2Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DisputeResolutionType2Choice.Code),nameof(DisputeResolutionType2Choice.Code))]
    [JsonDerivedType(typeof(DisputeResolutionType2Choice.ProprietaryIdentification),nameof(DisputeResolutionType2Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_UnrTydp-Ed-ak6NoX_4Aeg_-116466273")]
    [DisplayName("Dispute Resolution Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisputeResolutionType2Choice_
    #else
    public abstract partial class DisputeResolutionType2Choice_
    #endif
    {
    }
}
