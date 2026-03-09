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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument25Choice
{
    /// <summary>
    /// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
    /// </summary>
    [IsoId("_M8JPU_8REemYYvJytExgzA")]
    [DisplayName("Cheque Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ChequeDetails : PaymentInstrument25Choice_
    #else
    public partial class ChequeDetails : PaymentInstrument25Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for the cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_BS7wgf8REemYYvJytExgzA")]
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
        /// Party to which the cheque is made payable.
        /// </summary>
        [IsoId("_BS7wg_8REemYYvJytExgzA")]
        [DisplayName("Payee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PyeeId")]
        #endif
        [IsoXmlTag("PyeeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification139? PayeeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification139? PayeeIdentification { get; init; } 
        #else
        public PartyIdentification139? PayeeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution on which the cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_BS7whf8REemYYvJytExgzA")]
        [DisplayName("Drawee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrweeId")]
        #endif
        [IsoXmlTag("DrweeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
        #else
        public FinancialInstitutionIdentification17? DraweeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account owner that issues the cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_BS7wh_8REemYYvJytExgzA")]
        [DisplayName("Drawer Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrwrId")]
        #endif
        [IsoXmlTag("DrwrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification139? DrawerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification139? DrawerIdentification { get; init; } 
        #else
        public PartyIdentification139? DrawerIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
