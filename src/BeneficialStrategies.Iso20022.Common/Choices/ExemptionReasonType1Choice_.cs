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
    /// Choice of an exemption reason type.
    /// </summary>
    [KnownType(typeof(ExemptionReasonType1Choice.ExemptionReason))]
    [KnownType(typeof(ExemptionReasonType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExemptionReasonType1Choice.ExemptionReason),nameof(ExemptionReasonType1Choice.ExemptionReason))]
    [JsonDerivedType(typeof(ExemptionReasonType1Choice.Proprietary),nameof(ExemptionReasonType1Choice.Proprietary))]
    #endif
    [IsoId("_RgSsGNp-Ed-ak6NoX_4Aeg_340862287")]
    [DisplayName("Exemption Reason Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExemptionReasonType1Choice_
    #else
    public abstract partial class ExemptionReasonType1Choice_
    #endif
    {
    }
}
