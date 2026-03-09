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
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification4Choice.BIC))]
    [KnownType(typeof(FinancialInstitutionIdentification4Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstitutionIdentification4Choice.BIC),nameof(FinancialInstitutionIdentification4Choice.BIC))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification4Choice.NameAndAddress),nameof(FinancialInstitutionIdentification4Choice.NameAndAddress))]
    #endif
    [IsoId("_QEzlhtp-Ed-ak6NoX_4Aeg_-827596048")]
    [DisplayName("Financial Institution Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification4Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification4Choice_
    #endif
    {
    }
}
