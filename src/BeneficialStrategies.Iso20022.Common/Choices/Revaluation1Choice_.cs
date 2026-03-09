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
    /// Choice between an indicator or a data source scheme to determine the revaluation.
    /// </summary>
    [KnownType(typeof(Revaluation1Choice.Indicator))]
    [KnownType(typeof(Revaluation1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Revaluation1Choice.Indicator),nameof(Revaluation1Choice.Indicator))]
    [JsonDerivedType(typeof(Revaluation1Choice.Proprietary),nameof(Revaluation1Choice.Proprietary))]
    #endif
    [IsoId("_Q-eYdNp-Ed-ak6NoX_4Aeg_180533021")]
    [DisplayName("Revaluation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Revaluation1Choice_
    #else
    public abstract partial class Revaluation1Choice_
    #endif
    {
    }
}
