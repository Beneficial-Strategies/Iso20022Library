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
    [KnownType(typeof(Party6Choice.OrganisationIdentification))]
    [KnownType(typeof(Party6Choice.PrivateIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party6Choice.OrganisationIdentification),nameof(Party6Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party6Choice.PrivateIdentification),nameof(Party6Choice.PrivateIdentification))]
    #endif
    [IsoId("_Pa7iFNp-Ed-ak6NoX_4Aeg_567090753")]
    [DisplayName("Party 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party6Choice_
    #else
    public abstract partial class Party6Choice_
    #endif
    {
    }
}
