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
namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData1Choice
{
    /// <summary>
    /// Specific credit transfer mandate data.
    /// </summary>
    [IsoId("_2_Hf4clxEem0vqvvoqYsqQ")]
    [DisplayName("Credit Transfer Mandate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditTransferMandate : MandateRelatedData1Choice_
    #else
    public partial class CreditTransferMandate : MandateRelatedData1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_EgIuh8lqEem0vqvvoqYsqQ")]
        [DisplayName("Mandate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtId")]
        #endif
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateIdentification { get; init; } 
        #else
        public System.String? MandateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of mandate, such as paper, electronic or scheme.
        /// </summary>
        [IsoId("_CLrtsclsEem0vqvvoqYsqQ")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateTypeInformation2? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateTypeInformation2? Type { get; init; } 
        #else
        public MandateTypeInformation2? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the credit transfer mandate has been signed by the debtor.
        /// </summary>
        [IsoId("_EgIuiclqEem0vqvvoqYsqQ")]
        [DisplayName("Date Of Signature")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtOfSgntr")]
        #endif
        [IsoXmlTag("DtOfSgntr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? DateOfSignature { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? DateOfSignature { get; init; } 
        #else
        public System.DateOnly? DateOfSignature { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the credit transfer mandate has been verified.
        /// </summary>
        [IsoId("_MBcj0MlqEem0vqvvoqYsqQ")]
        [DisplayName("Date Of Verification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtOfVrfctn")]
        #endif
        [IsoXmlTag("DtOfVrfctn")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? DateOfVerification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? DateOfVerification { get; init; } 
        #else
        public System.DateTime? DateOfVerification { get; set; } 
        #endif
        
        /// <summary>
        /// Additional security provisions, such as a digital signature, as provided by the debtor.
        /// </summary>
        [IsoId("_EgIuj8lqEem0vqvvoqYsqQ")]
        [DisplayName("Electronic Signature")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ElctrncSgntr")]
        #endif
        [IsoXmlTag("ElctrncSgntr")]
        [IsoSimpleType(IsoSimpleType.Max10KBinary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax10KBinary? ElectronicSignature { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? ElectronicSignature { get; init; } 
        #else
        public System.Byte[]? ElectronicSignature { get; set; } 
        #endif
        
        /// <summary>
        /// Date of the first payment of a recurrent credit transfer as per the mandate.
        /// </summary>
        [IsoId("_EgIukclqEem0vqvvoqYsqQ")]
        [DisplayName("First Payment Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrstPmtDt")]
        #endif
        [IsoXmlTag("FrstPmtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? FirstPaymentDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? FirstPaymentDate { get; init; } 
        #else
        public System.DateOnly? FirstPaymentDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date of the final payment of a recurrent credit transfer as per the mandate.
        /// </summary>
        [IsoId("_EgIuk8lqEem0vqvvoqYsqQ")]
        [DisplayName("Final Payment Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FnlPmtDt")]
        #endif
        [IsoXmlTag("FnlPmtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? FinalPaymentDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? FinalPaymentDate { get; init; } 
        #else
        public System.DateOnly? FinalPaymentDate { get; set; } 
        #endif
        
        /// <summary>
        /// Regularity with which credit transfer instructions are to be created and processed.
        /// </summary>
        [IsoId("_EgIulclqEem0vqvvoqYsqQ")]
        [DisplayName("Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Frqcy")]
        #endif
        [IsoXmlTag("Frqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency36Choice_? Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency36Choice_? Frequency { get; init; } 
        #else
        public Frequency36Choice_? Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the setup of the credit transfer mandate.
        /// Usage: 
        /// The reason will allow the user to distinguish between different mandates for the same creditor.
        /// </summary>
        [IsoId("_EgIul8lqEem0vqvvoqYsqQ")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #else
        public MandateSetupReason1Choice_? Reason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
