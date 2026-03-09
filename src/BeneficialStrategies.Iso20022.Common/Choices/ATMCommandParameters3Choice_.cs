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
    /// Specific parameters attached to an ATM command.
    /// </summary>
    [KnownType(typeof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters3Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters3Choice.RequiredConfigurationParameter))]
    [KnownType(typeof(ATMCommandParameters3Choice.RequiredSecurityScheme))]
    [KnownType(typeof(ATMCommandParameters3Choice.SecurityDevice))]
    [KnownType(typeof(ATMCommandParameters3Choice.Key))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus),nameof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus))]
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.ExpectedMessageFunction),nameof(ATMCommandParameters3Choice.ExpectedMessageFunction))]
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.RequiredConfigurationParameter),nameof(ATMCommandParameters3Choice.RequiredConfigurationParameter))]
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.RequiredSecurityScheme),nameof(ATMCommandParameters3Choice.RequiredSecurityScheme))]
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.SecurityDevice),nameof(ATMCommandParameters3Choice.SecurityDevice))]
    [JsonDerivedType(typeof(ATMCommandParameters3Choice.Key),nameof(ATMCommandParameters3Choice.Key))]
    #endif
    [IsoId("_hk_BUV2aEeekzJIz1JxYSQ")]
    [DisplayName("ATM Command Parameters 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ATMCommandParameters3Choice_
    #else
    public abstract partial class ATMCommandParameters3Choice_
    #endif
    {
    }
}
