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
    [KnownType(typeof(TrackerParty2Choice.OrganisationIdentification))]
    [KnownType(typeof(TrackerParty2Choice.PrivateIdentification))]
    [KnownType(typeof(TrackerParty2Choice.FinancialInstitutionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TrackerParty2Choice.OrganisationIdentification),nameof(TrackerParty2Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(TrackerParty2Choice.PrivateIdentification),nameof(TrackerParty2Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(TrackerParty2Choice.FinancialInstitutionIdentification),nameof(TrackerParty2Choice.FinancialInstitutionIdentification))]
    #endif
    [IsoId("_dWHWv2OTEeq5Ar_w98FvsA")]
    [DisplayName("Tracker Party 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TrackerParty2Choice_
    #else
    public abstract partial class TrackerParty2Choice_
    #endif
    {
    }
}
