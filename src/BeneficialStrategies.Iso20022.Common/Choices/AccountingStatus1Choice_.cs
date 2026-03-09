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
    /// Choice of formats for the accounting status.
    /// </summary>
    [KnownType(typeof(AccountingStatus1Choice.Code))]
    [KnownType(typeof(AccountingStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountingStatus1Choice.Code),nameof(AccountingStatus1Choice.Code))]
    [JsonDerivedType(typeof(AccountingStatus1Choice.Proprietary),nameof(AccountingStatus1Choice.Proprietary))]
    #endif
    [IsoId("_9Oz2cCDDEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountingStatus1Choice_
    #else
    public abstract partial class AccountingStatus1Choice_
    #endif
    {
    }
}
