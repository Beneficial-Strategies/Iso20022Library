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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [KnownType(typeof(RemittanceInformation3Choice.Unstructured))]
    [KnownType(typeof(RemittanceInformation3Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RemittanceInformation3Choice.Unstructured),nameof(RemittanceInformation3Choice.Unstructured))]
    [JsonDerivedType(typeof(RemittanceInformation3Choice.Structured),nameof(RemittanceInformation3Choice.Structured))]
    #endif
    [IsoId("_Rb1C1tp-Ed-ak6NoX_4Aeg_-609212220")]
    [DisplayName("Remittance Information 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RemittanceInformation3Choice_
    #else
    public abstract partial class RemittanceInformation3Choice_
    #endif
    {
    }
}
