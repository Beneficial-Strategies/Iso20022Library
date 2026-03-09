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
    [KnownType(typeof(Party38Choice.OrganisationIdentification))]
    [KnownType(typeof(Party38Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party38Choice.OrganisationIdentification),nameof(Party38Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party38Choice.PrivateIdentification),nameof(Party38Choice.PrivateIdentification))]
    #endif
    [IsoId("_6L-JzW48EeiU9cctagi5ow")]
    [DisplayName("Party 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party38Choice_
    #else
    public abstract partial class Party38Choice_
    #endif
    {
    }
}
