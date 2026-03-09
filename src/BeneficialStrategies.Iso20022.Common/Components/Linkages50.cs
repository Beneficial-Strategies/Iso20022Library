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
/// Information related to a linked transaction.
/// </summary>
[IsoId("_dsRUYb-CEeW_u_CSZtGM1g")]
[DisplayName("Linkages")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages50
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages50 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages50( System.String reqSecuritiesSettlementTransactionIdentification )
    {
        SecuritiesSettlementTransactionIdentification = reqSecuritiesSettlementTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction - for information only.
    /// </summary>
    [IsoId("_eEEwYb-CEeW_u_CSZtGM1g")]
    [DisplayName("Processing Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgPos")]
    #endif
    [IsoXmlTag("PrcgPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition23Choice_? ProcessingPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition23Choice_? ProcessingPosition { get; init; } 
    #else
    public ProcessingPosition23Choice_? ProcessingPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_eEEwY7-CEeW_u_CSZtGM1g")]
    [DisplayName("Securities Settlement Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmTxId")]
    #endif
    [IsoXmlTag("SctiesSttlmTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text SecuritiesSettlementTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecuritiesSettlementTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecuritiesSettlementTransactionIdentification { get; init; } 
    #else
    public System.String SecuritiesSettlementTransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
