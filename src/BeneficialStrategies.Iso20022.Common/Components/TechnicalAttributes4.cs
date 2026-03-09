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
/// Specifies technical attributes of the message.
/// </summary>
[IsoId("_bzI8cXhCEeu3kecHd7QKUQ")]
[DisplayName("Technical Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TechnicalAttributes4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_cCm70XhCEeu3kecHd7QKUQ")]
    [DisplayName("Reconciliation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnFlg")]
    #endif
    [IsoXmlTag("RcncltnFlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reconciliation2Code? ReconciliationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reconciliation2Code? ReconciliationFlag { get; init; } 
    #else
    public Reconciliation2Code? ReconciliationFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
