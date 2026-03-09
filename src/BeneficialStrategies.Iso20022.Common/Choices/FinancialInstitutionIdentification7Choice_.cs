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
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.NameAndAddress),nameof(FinancialInstitutionIdentification7Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.BICFI),nameof(FinancialInstitutionIdentification7Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification7Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification7Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_TBZxQSGOEeW7gKYhAMEFCw")]
    [DisplayName("Financial Institution Identification 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification7Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification7Choice_
    #endif
    {
    }
}
