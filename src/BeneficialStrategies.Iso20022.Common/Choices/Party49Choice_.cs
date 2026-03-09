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
    [KnownType(typeof(Party49Choice.OrganisationIdentification))]
    [KnownType(typeof(Party49Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party49Choice.OrganisationIdentification),nameof(Party49Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party49Choice.PrivateIdentification),nameof(Party49Choice.PrivateIdentification))]
    #endif
    [IsoId("_dPk6ceEpEemRzcIkmUETeA")]
    [DisplayName("Party 49 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party49Choice_
    #else
    public abstract partial class Party49Choice_
    #endif
    {
    }
}
