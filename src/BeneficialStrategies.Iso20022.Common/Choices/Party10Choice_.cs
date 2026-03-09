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
    [KnownType(typeof(Party10Choice.OrganisationIdentification))]
    [KnownType(typeof(Party10Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party10Choice.OrganisationIdentification),nameof(Party10Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party10Choice.PrivateIdentification),nameof(Party10Choice.PrivateIdentification))]
    #endif
    [IsoId("_PWwzwtp-Ed-ak6NoX_4Aeg_-2096726580")]
    [DisplayName("Party 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party10Choice_
    #else
    public abstract partial class Party10Choice_
    #endif
    {
    }
}
