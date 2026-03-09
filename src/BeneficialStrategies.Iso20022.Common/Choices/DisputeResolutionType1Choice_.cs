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
    [KnownType(typeof(DisputeResolutionType1Choice.Code))]
    [KnownType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DisputeResolutionType1Choice.Code),nameof(DisputeResolutionType1Choice.Code))]
    [JsonDerivedType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification),nameof(DisputeResolutionType1Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_QmogNdp-Ed-ak6NoX_4Aeg_1282948020")]
    [DisplayName("Dispute Resolution Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisputeResolutionType1Choice_
    #else
    public abstract partial class DisputeResolutionType1Choice_
    #endif
    {
    }
}
