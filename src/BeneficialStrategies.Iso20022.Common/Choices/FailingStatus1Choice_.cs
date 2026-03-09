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
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailingStatus1Choice.NoSpecifiedReason),nameof(FailingStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus1Choice.Reason),nameof(FailingStatus1Choice.Reason))]
    #endif
    [IsoId("_UZqs9tp-Ed-ak6NoX_4Aeg_1207630782")]
    [DisplayName("Failing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus1Choice_
    #else
    public abstract partial class FailingStatus1Choice_
    #endif
    {
    }
}
