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
    /// Choice between formats for the specification of a tax.
    /// </summary>
    [KnownType(typeof(TaxAmountOrRate4Choice.Amount))]
    [KnownType(typeof(TaxAmountOrRate4Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxAmountOrRate4Choice.Amount),nameof(TaxAmountOrRate4Choice.Amount))]
    [JsonDerivedType(typeof(TaxAmountOrRate4Choice.Rate),nameof(TaxAmountOrRate4Choice.Rate))]
    #endif
    [IsoId("_mnR34EUWEea21qTBwbMSEA")]
    [DisplayName("Tax Amount Or Rate 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxAmountOrRate4Choice_
    #else
    public abstract partial class TaxAmountOrRate4Choice_
    #endif
    {
    }
}
