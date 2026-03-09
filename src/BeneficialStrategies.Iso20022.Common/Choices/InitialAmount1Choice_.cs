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
    /// Choice of an initial amount or number of pre-paid instalments.
    /// </summary>
    [KnownType(typeof(InitialAmount1Choice.InitialNumberOfInstalments))]
    [KnownType(typeof(InitialAmount1Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InitialAmount1Choice.InitialNumberOfInstalments),nameof(InitialAmount1Choice.InitialNumberOfInstalments))]
    [JsonDerivedType(typeof(InitialAmount1Choice.Amount),nameof(InitialAmount1Choice.Amount))]
    #endif
    [IsoId("_Ru9ewCDaEeWCLu74WLgP4w")]
    [DisplayName("Initial Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InitialAmount1Choice_
    #else
    public abstract partial class InitialAmount1Choice_
    #endif
    {
    }
}
