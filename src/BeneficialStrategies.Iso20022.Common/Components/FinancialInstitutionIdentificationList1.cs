// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of centralised branch identifiers.
/// </summary>
[IsoId("_3iqTICD0Eeav65mEytrgaA")]
[DisplayName("Financial Institution Identification List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentificationList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Repeated identifiers.
    /// </summary>
    [IsoId("_Bwxs8CD1Eeav65mEytrgaA")]
    [DisplayName("List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="List")]
    #endif
    [IsoXmlTag("List")]
    public ValueList<FinancialInstitutionIdentification9> List { get; init; } = new ValueList<FinancialInstitutionIdentification9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Bwxs8CD1Eeav65mEytrgaA
    
    
    #nullable disable
    
}
