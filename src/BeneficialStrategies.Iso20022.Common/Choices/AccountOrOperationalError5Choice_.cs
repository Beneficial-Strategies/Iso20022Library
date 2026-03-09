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
    /// Choice between account details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrOperationalError5Choice.AccountReport))]
    [KnownType(typeof(AccountOrOperationalError5Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountOrOperationalError5Choice.AccountReport),nameof(AccountOrOperationalError5Choice.AccountReport))]
    [JsonDerivedType(typeof(AccountOrOperationalError5Choice.OperationalError),nameof(AccountOrOperationalError5Choice.OperationalError))]
    #endif
    [IsoId("_fAfGYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Operational Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountOrOperationalError5Choice_
    #else
    public abstract partial class AccountOrOperationalError5Choice_
    #endif
    {
    }
}
