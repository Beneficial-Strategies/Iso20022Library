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
    [KnownType(typeof(Party11Choice.OrganisationIdentification))]
    [KnownType(typeof(Party11Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party11Choice.OrganisationIdentification),nameof(Party11Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party11Choice.PrivateIdentification),nameof(Party11Choice.PrivateIdentification))]
    #endif
    [IsoId("_PWnCwtp-Ed-ak6NoX_4Aeg_2128331948")]
    [DisplayName("Party 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party11Choice_
    #else
    public abstract partial class Party11Choice_
    #endif
    {
    }
}
