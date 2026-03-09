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
    /// Choice between the different options to search for an account.
    /// </summary>
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.Equal))]
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.ContainText))]
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.NotContainText))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentificationSearchCriteria2Choice.Equal),nameof(AccountIdentificationSearchCriteria2Choice.Equal))]
    [JsonDerivedType(typeof(AccountIdentificationSearchCriteria2Choice.ContainText),nameof(AccountIdentificationSearchCriteria2Choice.ContainText))]
    [JsonDerivedType(typeof(AccountIdentificationSearchCriteria2Choice.NotContainText),nameof(AccountIdentificationSearchCriteria2Choice.NotContainText))]
    #endif
    [IsoId("_g7QEuGliEeGaMcKyqKNRfQ_-836272256")]
    [DisplayName("Account Identification Search Criteria 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentificationSearchCriteria2Choice_
    #else
    public abstract partial class AccountIdentificationSearchCriteria2Choice_
    #endif
    {
    }
}
