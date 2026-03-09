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
/// Specifies the amendment of the information that serves as a basis to debit an account.
/// </summary>
[IsoId("_UQacM-H7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtorActivationAmendment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific attributes provided the debtor, as requested by the creditor, for the activation request.
    /// </summary>
    [IsoId("_URmu4eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Debtor Activation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrActvtn")]
    #endif
    [IsoXmlTag("DbtrActvtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtorActivation4? DebtorActivation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivation4? DebtorActivation { get; init; } 
    #else
    public DebtorActivation4? DebtorActivation { get; set; } 
    #endif
    
    /// <summary>
    /// Further data related to the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_URmu4-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Electronic Invoice Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncInvcData")]
    #endif
    [IsoXmlTag("ElctrncInvcData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ElectronicInvoice1? ElectronicInvoiceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectronicInvoice1? ElectronicInvoiceData { get; init; } 
    #else
    public ElectronicInvoice1? ElectronicInvoiceData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
