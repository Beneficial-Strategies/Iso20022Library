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
    [KnownType(typeof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters2Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters2Choice.RequiredConfigurationParameter))]
    [KnownType(typeof(ATMCommandParameters2Choice.RequiredSecurityScheme))]
    [KnownType(typeof(ATMCommandParameters2Choice.SecurityDevice))]
    [KnownType(typeof(ATMCommandParameters2Choice.Key))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus),nameof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.ExpectedMessageFunction),nameof(ATMCommandParameters2Choice.ExpectedMessageFunction))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.RequiredConfigurationParameter),nameof(ATMCommandParameters2Choice.RequiredConfigurationParameter))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.RequiredSecurityScheme),nameof(ATMCommandParameters2Choice.RequiredSecurityScheme))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.SecurityDevice),nameof(ATMCommandParameters2Choice.SecurityDevice))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.Key),nameof(ATMCommandParameters2Choice.Key))]
    #endif
    [IsoId("_pz3tsYtHEeSxlKlAGYErFg")]
    [DisplayName("ATM Command Parameters 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ATMCommandParameters2Choice_
    #else
    public abstract partial class ATMCommandParameters2Choice_
    #endif
    {
    }
}
