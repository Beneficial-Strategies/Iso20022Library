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
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.NameAndAddress))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.BICFI))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.NameAndAddress),nameof(FinancialInstitutionIdentification11Choice.NameAndAddress))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.BICFI),nameof(FinancialInstitutionIdentification11Choice.BICFI))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification),nameof(FinancialInstitutionIdentification11Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification),nameof(FinancialInstitutionIdentification11Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_RBDV4ZS7EemqYPWMBuVawg")]
    [DisplayName("Financial Institution Identification 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstitutionIdentification11Choice_
    #else
    public abstract partial class FinancialInstitutionIdentification11Choice_
    #endif
    {
    }
}
