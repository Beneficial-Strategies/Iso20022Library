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
    /// Choice between the identification of a person and the identification of a non-financial institution.
    /// </summary>
    [KnownType(typeof(Party2Choice.OrganisationIdentification))]
    [KnownType(typeof(Party2Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party2Choice.OrganisationIdentification),nameof(Party2Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party2Choice.PrivateIdentification),nameof(Party2Choice.PrivateIdentification))]
    #endif
    [IsoId("_RCDQ4Np-Ed-ak6NoX_4Aeg_-1691234030")]
    [DisplayName("Party 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party2Choice_
    #else
    public abstract partial class Party2Choice_
    #endif
    {
    }
}
