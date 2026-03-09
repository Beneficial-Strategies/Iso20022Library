// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// The Any element without further validation processing.
/// </summary>
[IsoId("_RreBWNp-Ed-ak6NoX_4Aeg_-72452402")]
[DisplayName("Skip Processing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SkipProcessing
{
    #nullable enable
    
    
    #nullable disable
    
}
