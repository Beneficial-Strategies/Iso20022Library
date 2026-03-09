// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument10Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_VKY_SNp-Ed-ak6NoX_4Aeg_734057917")]
    [DisplayName("Credit Transfer Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditTransferDetails : PaymentInstrument10Choice_
    #else
    public partial class CreditTransferDetails : PaymentInstrument10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditTransferDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditTransferDetails( Debtor2 reqDebtorDetails )
        {
            DebtorDetails = reqDebtorDetails;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_VRiwKdp-Ed-ak6NoX_4Aeg_949302766")]
        [DisplayName("Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ref")]
        #endif
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reference { get; init; } 
        #else
        public System.String? Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. The creditor is also the credit account owner.
        /// </summary>
        [IsoId("_VRshINp-Ed-ak6NoX_4Aeg_949302826")]
        [DisplayName("Creditor Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrDtls")]
        #endif
        [IsoXmlTag("CdtrDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Creditor2? CreditorDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Creditor2? CreditorDetails { get; init; } 
        #else
        public Creditor2? CreditorDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
        /// </summary>
        [IsoId("_VRshIdp-Ed-ak6NoX_4Aeg_949302784")]
        [DisplayName("Debtor Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrDtls")]
        #endif
        [IsoXmlTag("DbtrDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Debtor2 DebtorDetails { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Debtor2 DebtorDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Debtor2 DebtorDetails { get; init; } 
        #else
        public Debtor2 DebtorDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
