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
    /// Specifies one or a range of securities accounts.
    /// </summary>
    [KnownType(typeof(SecuritiesAccount2Choice.Range))]
    [KnownType(typeof(SecuritiesAccount2Choice.Account))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Range),nameof(SecuritiesAccount2Choice.Range))]
    [JsonDerivedType(typeof(SecuritiesAccount2Choice.Account),nameof(SecuritiesAccount2Choice.Account))]
    #endif
    [IsoId("_38iun-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccount2Choice_
    #else
    public abstract partial class SecuritiesAccount2Choice_
    #endif
    {
    }
}
