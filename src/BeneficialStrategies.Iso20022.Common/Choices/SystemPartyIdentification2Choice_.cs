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
    /// Choice between an identification of a party or a combination of the responsible party identification and the business identifier.
    /// </summary>
    [KnownType(typeof(SystemPartyIdentification2Choice.OrganisationIdentification))]
    [KnownType(typeof(SystemPartyIdentification2Choice.CombinedIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemPartyIdentification2Choice.OrganisationIdentification),nameof(SystemPartyIdentification2Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(SystemPartyIdentification2Choice.CombinedIdentification),nameof(SystemPartyIdentification2Choice.CombinedIdentification))]
    #endif
    [IsoId("_wwhf0Wc-EemvNLufWGIVOQ")]
    [DisplayName("System Party Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemPartyIdentification2Choice_
    #else
    public abstract partial class SystemPartyIdentification2Choice_
    #endif
    {
    }
}
