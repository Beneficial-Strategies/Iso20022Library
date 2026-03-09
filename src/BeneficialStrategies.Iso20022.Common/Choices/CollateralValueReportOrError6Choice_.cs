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
    /// Business report on collateral value or business error.
    /// </summary>
    [KnownType(typeof(CollateralValueReportOrError6Choice.BusinessError))]
    [KnownType(typeof(CollateralValueReportOrError6Choice.CollateralValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralValueReportOrError6Choice.BusinessError),nameof(CollateralValueReportOrError6Choice.BusinessError))]
    [JsonDerivedType(typeof(CollateralValueReportOrError6Choice.CollateralValue),nameof(CollateralValueReportOrError6Choice.CollateralValue))]
    #endif
    [IsoId("_EFF_UTpyEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Report Or Error 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralValueReportOrError6Choice_
    #else
    public abstract partial class CollateralValueReportOrError6Choice_
    #endif
    {
    }
}
