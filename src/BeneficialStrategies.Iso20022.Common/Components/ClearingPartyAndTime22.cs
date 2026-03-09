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
/// Specifies the central counterparty clearing time.
/// </summary>
[IsoId("_-GFDERZNEe2QNcZTDeoKnQ")]
[DisplayName("Clearing Party And Time")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingPartyAndTime22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    [IsoId("_-HsMpxZNEe2QNcZTDeoKnQ")]
    [DisplayName("CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCP")]
    #endif
    [IsoXmlTag("CCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? CCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? CCP { get; init; } 
    #else
    public OrganisationIdentification15Choice_? CCP { get; set; } 
    #endif
    
    /// <summary>
    /// Time and date when the original derivative was received by the central counterparty for clearing.
    /// </summary>
    [IsoId("_-HsMqRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Receipt Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrRctDtTm")]
    #endif
    [IsoXmlTag("ClrRctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ClearingReceiptDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ClearingReceiptDateTime { get; init; } 
    #else
    public System.DateTime? ClearingReceiptDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    [IsoId("_-HsMqxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtTm")]
    #endif
    [IsoXmlTag("ClrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ClearingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ClearingDateTime { get; init; } 
    #else
    public System.DateTime? ClearingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of each clearing derivative that replaces the original derivative that was submitted for clearing to the central counterparty, other than the identifier for the transaction being reported.
    /// </summary>
    [IsoId("_-HsMrRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrIdr")]
    #endif
    [IsoXmlTag("ClrIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2Choice_? ClearingIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2Choice_? ClearingIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier2Choice_? ClearingIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
    /// </summary>
    [IsoId("_-HsMrxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Original Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlIdr")]
    #endif
    [IsoXmlTag("OrgnlIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2Choice_? OriginalIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2Choice_? OriginalIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier2Choice_? OriginalIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trade repository to which the original derivative was reported.
    /// </summary>
    [IsoId("_-HsMsRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Original Trade Repository Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTradRpstryIdr")]
    #endif
    [IsoXmlTag("OrgnlTradRpstryIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; init; } 
    #else
    public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of whether the clearing member acted as principal for a house trade or an agent for a customer trade.
    /// </summary>
    [IsoId("_-HsMsxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Account Origin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcctOrgn")]
    #endif
    [IsoXmlTag("ClrAcctOrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingAccountType4Code? ClearingAccountOrigin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingAccountType4Code? ClearingAccountOrigin { get; init; } 
    #else
    public ClearingAccountType4Code? ClearingAccountOrigin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
