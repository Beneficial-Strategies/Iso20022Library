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
    [KnownType(typeof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters1Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters1Choice.RequiredConfigurationParameter))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus),nameof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus))]
    [JsonDerivedType(typeof(ATMCommandParameters1Choice.ExpectedMessageFunction),nameof(ATMCommandParameters1Choice.ExpectedMessageFunction))]
    [JsonDerivedType(typeof(ATMCommandParameters1Choice.RequiredConfigurationParameter),nameof(ATMCommandParameters1Choice.RequiredConfigurationParameter))]
    #endif
    [IsoId("_JTG3oIqLEeSRT5rEzcAHEw")]
    [DisplayName("ATM Command Parameters 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ATMCommandParameters1Choice_
    #else
    public abstract partial class ATMCommandParameters1Choice_
    #endif
    {
    }
}
