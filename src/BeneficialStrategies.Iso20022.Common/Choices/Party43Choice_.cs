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
    [KnownType(typeof(Party43Choice.OrganisationIdentification))]
    [KnownType(typeof(Party43Choice.FinancialInstitutionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party43Choice.OrganisationIdentification),nameof(Party43Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party43Choice.FinancialInstitutionIdentification),nameof(Party43Choice.FinancialInstitutionIdentification))]
    #endif
    [IsoId("_BgdrHW49EeiU9cctagi5ow")]
    [DisplayName("Party 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party43Choice_
    #else
    public abstract partial class Party43Choice_
    #endif
    {
    }
}
