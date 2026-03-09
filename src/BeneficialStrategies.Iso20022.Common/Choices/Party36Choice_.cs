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
    [KnownType(typeof(Party36Choice.OrganisationIdentification))]
    [KnownType(typeof(Party36Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party36Choice.OrganisationIdentification),nameof(Party36Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party36Choice.PrivateIdentification),nameof(Party36Choice.PrivateIdentification))]
    #endif
    [IsoId("_2lSwceWkEeevU7McUP3D1w")]
    [DisplayName("Party 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party36Choice_
    #else
    public abstract partial class Party36Choice_
    #endif
    {
    }
}
