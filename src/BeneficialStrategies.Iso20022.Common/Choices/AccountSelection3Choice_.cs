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
    /// Choice of criteria for the identification of an account.
    /// </summary>
    [KnownType(typeof(AccountSelection3Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection3Choice.OtherAccountSelectionData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountSelection3Choice.AccountIdentification),nameof(AccountSelection3Choice.AccountIdentification))]
    [JsonDerivedType(typeof(AccountSelection3Choice.OtherAccountSelectionData),nameof(AccountSelection3Choice.OtherAccountSelectionData))]
    #endif
    [IsoId("_n9ODwZTIEemqYPWMBuVawg")]
    [DisplayName("Account Selection 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountSelection3Choice_
    #else
    public abstract partial class AccountSelection3Choice_
    #endif
    {
    }
}
