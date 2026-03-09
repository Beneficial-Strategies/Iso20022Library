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
    [KnownType(typeof(AccountSelection1Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection1Choice.OtherAccountSelectionData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountSelection1Choice.AccountIdentification),nameof(AccountSelection1Choice.AccountIdentification))]
    [JsonDerivedType(typeof(AccountSelection1Choice.OtherAccountSelectionData),nameof(AccountSelection1Choice.OtherAccountSelectionData))]
    #endif
    [IsoId("_8u7sACFREeWgV9SQSyaAog")]
    [DisplayName("Account Selection 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountSelection1Choice_
    #else
    public abstract partial class AccountSelection1Choice_
    #endif
    {
    }
}
