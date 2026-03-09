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
/// Number of individual reports or transactions received / sent, detailed per validation rule.
/// </summary>
[IsoId("_vUlOcU2UEe2bQ-Ksk8mwQg")]
[DisplayName("Number Of Transactions Per Validation Rule")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfTransactionsPerValidationRule6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfTransactionsPerValidationRule6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfTransactionsPerValidationRule6( System.String reqDetailedNumber )
    {
        DetailedNumber = reqDetailedNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual reports or transactions sent / received, detailed per status.
    /// </summary>
    [IsoId("_vVXRkU2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Detailed Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldNb")]
    #endif
    [IsoXmlTag("DtldNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DetailedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumber { get; init; } 
    #else
    public System.String DetailedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Common validation rule for all individual reports received.
    /// </summary>
    [IsoId("_vVXRk02UEe2bQ-Ksk8mwQg")]
    [DisplayName("Report Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSts")]
    #endif
    [IsoXmlTag("RptSts")]
    public ValueList<RejectionReason70> ReportStatus { get; init; } = new ValueList<RejectionReason70>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _vVXRk02UEe2bQ-Ksk8mwQg
    
    
    #nullable disable
    
}
