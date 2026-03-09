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
/// Element containing all information needed for a card initiating direct debit.
/// </summary>
[IsoId("_sk2rwNprEeearpaEPXv9UA")]
[DisplayName("Card Direct Debit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardDirectDebit1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardDirectDebit1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardDirectDebit1( Creditor3 reqCreditorIdentification,MandateRelatedInformation13 reqMandateRelatedInformation )
    {
        CreditorIdentification = reqCreditorIdentification;
        MandateRelatedInformation = reqMandateRelatedInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the debtor.
    /// </summary>
    [IsoId("_8npZ8NprEeearpaEPXv9UA")]
    [DisplayName("Debtor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrId")]
    #endif
    [IsoXmlTag("DbtrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Debtor3? DebtorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Debtor3? DebtorIdentification { get; init; } 
    #else
    public Debtor3? DebtorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the creditor.
    /// </summary>
    [IsoId("_Gz814NpsEeearpaEPXv9UA")]
    [DisplayName("Creditor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrId")]
    #endif
    [IsoXmlTag("CdtrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Creditor3 CreditorIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Creditor3 CreditorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Creditor3 CreditorIdentification { get; init; } 
    #else
    public Creditor3 CreditorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_OPR_ANpsEeearpaEPXv9UA")]
    [DisplayName("Mandate Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtRltdInf")]
    #endif
    [IsoXmlTag("MndtRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateRelatedInformation13 MandateRelatedInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MandateRelatedInformation13 MandateRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateRelatedInformation13 MandateRelatedInformation { get; init; } 
    #else
    public MandateRelatedInformation13 MandateRelatedInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
