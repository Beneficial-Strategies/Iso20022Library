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
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party13Choice.OrganisationIdentification))]
    [KnownType(typeof(Party13Choice.FinancialInstitutionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party13Choice.OrganisationIdentification),nameof(Party13Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party13Choice.FinancialInstitutionIdentification),nameof(Party13Choice.FinancialInstitutionIdentification))]
    #endif
    [IsoId("_6Q10g5qlEeGSON8vddiWzQ_1947841823")]
    [DisplayName("Party 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party13Choice_
    #else
    public abstract partial class Party13Choice_
    #endif
    {
    }
}
