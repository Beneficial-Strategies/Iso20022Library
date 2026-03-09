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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice
{
    /// <summary>
    /// Cheque drawn by a bank on itself or its agent. A person who owes money to another buys the draft from a bank for cash and hands it to the creditor.
    /// </summary>
    [IsoId("_weKLITbsEead9bDRE_1DAQ")]
    [DisplayName("Bankers Draft Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BankersDraftDetails : PaymentInstrument20Choice_
    #else
    public partial class BankersDraftDetails : PaymentInstrument20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BankersDraftDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BankersDraftDetails( PartyIdentification113 reqPayeeIdentification )
        {
            PayeeIdentification = reqPayeeIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_w3AI4TbsEead9bDRE_1DAQ")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Number { get; init; } 
        #else
        public System.String? Number { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which a cheque is made payable.
        /// </summary>
        [IsoId("_w3AI4zbsEead9bDRE_1DAQ")]
        [DisplayName("Payee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PyeeId")]
        #endif
        [IsoXmlTag("PyeeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification113 PayeeIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification113 PayeeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification113 PayeeIdentification { get; init; } 
        #else
        public PartyIdentification113 PayeeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution on which a cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_w3AI5TbsEead9bDRE_1DAQ")]
        [DisplayName("Drawee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrweeId")]
        #endif
        [IsoXmlTag("DrweeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification10? DraweeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification10? DraweeIdentification { get; init; } 
        #else
        public FinancialInstitutionIdentification10? DraweeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_w3AI5zbsEead9bDRE_1DAQ")]
        [DisplayName("Drawer Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrwrId")]
        #endif
        [IsoXmlTag("DrwrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification113? DrawerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification113? DrawerIdentification { get; init; } 
        #else
        public PartyIdentification113? DrawerIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
