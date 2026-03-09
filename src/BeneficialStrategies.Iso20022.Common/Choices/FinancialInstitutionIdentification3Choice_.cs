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
    /// Choice between formats for the identification of the financial institution.
    /// </summary>
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.BIC))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.NameAndAddress),nameof(FinancialInstitutionIdentification3Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.BIC),nameof(FinancialInstitutionIdentification3Choice.BIC))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification3Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification3Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_QE8vcNp-Ed-ak6NoX_4Aeg_2089460166")]
    [DisplayName("Financial Institution Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification3Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification3Choice_
    #endif
    {
    }
}
