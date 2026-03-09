// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.ExternalSchema;

/// <summary>
/// Technical component that contains the validated supplementary data information. This technical envelope allows to segregate the supplementary data information from any other information.
/// </summary>
public partial record SupplementaryDataEnvelope1
{
    #nullable enable
    
    
    #nullable disable
    
}
