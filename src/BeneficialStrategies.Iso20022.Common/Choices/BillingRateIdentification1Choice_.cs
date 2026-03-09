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
    /// Specifies the billing rate identification code.
    /// </summary>
    [KnownType(typeof(BillingRateIdentification1Choice.Code))]
    [KnownType(typeof(BillingRateIdentification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BillingRateIdentification1Choice.Code),nameof(BillingRateIdentification1Choice.Code))]
    [JsonDerivedType(typeof(BillingRateIdentification1Choice.Proprietary),nameof(BillingRateIdentification1Choice.Proprietary))]
    #endif
    [IsoId("_6Q10hpqlEeGSON8vddiWzQ_1451899054")]
    [DisplayName("Billing Rate Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BillingRateIdentification1Choice_
    #else
    public abstract partial class BillingRateIdentification1Choice_
    #endif
    {
    }
}
