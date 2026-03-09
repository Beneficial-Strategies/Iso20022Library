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
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstitutionIdentification8Choice.NameAndAddress),nameof(FinancialInstitutionIdentification8Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification8Choice.BICFI),nameof(FinancialInstitutionIdentification8Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification8Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification8Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_M0nFYTfAEeaijYcl4fyXoQ")]
    [DisplayName("Financial Institution Identification 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification8Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification8Choice_
    #endif
    {
    }
}
