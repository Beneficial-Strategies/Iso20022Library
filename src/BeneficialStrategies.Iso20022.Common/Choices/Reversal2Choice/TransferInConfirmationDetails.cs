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
namespace BeneficialStrategies.Iso20022.Choices.Reversal2Choice
{
    /// <summary>
    /// Details of the transfer in confirmation to be reversed.
    /// </summary>
    [IsoId("_QDM4fBg4EeK-_89we2b-bA")]
    [DisplayName("Transfer In Confirmation Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TransferInConfirmationDetails : Reversal2Choice_
    #else
    public partial class TransferInConfirmationDetails : Reversal2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TransferInConfirmationDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TransferInConfirmationDetails( InvestmentAccount22 reqAccountDetails )
        {
            AccountDetails = reqAccountDetails;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// General information related to the transfer of a financial instrument.
        /// </summary>
        [IsoId("_RFpSFRgmEeK-_89we2b-bA")]
        [DisplayName("Transfer Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfDtls")]
        #endif
        [IsoXmlTag("TrfDtls")]
        public ValueList<Transfer25> TransferDetails { get; init; } = new ValueList<Transfer25>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RFpSFRgmEeK-_89we2b-bA
        
        /// <summary>
        /// Information related to the account into which the financial instrument was received.
        /// </summary>
        [IsoId("_RFpSGRgmEeK-_89we2b-bA")]
        [DisplayName("Account Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctDtls")]
        #endif
        [IsoXmlTag("AcctDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvestmentAccount22 AccountDetails { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InvestmentAccount22 AccountDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentAccount22 AccountDetails { get; init; } 
        #else
        public InvestmentAccount22 AccountDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the delivering side of the transfer.
        /// </summary>
        [IsoId("_RFpSHRgmEeK-_89we2b-bA")]
        [DisplayName("Settlement Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmDtls")]
        #endif
        [IsoXmlTag("SttlmDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DeliverInformation11? SettlementDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DeliverInformation11? SettlementDetails { get; init; } 
        #else
        public DeliverInformation11? SettlementDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_RFpSIRgmEeK-_89we2b-bA")]
        [DisplayName("Extension")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Xtnsn")]
        #endif
        [IsoXmlTag("Xtnsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Extension1? Extension { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Extension1? Extension { get; init; } 
        #else
        public Extension1? Extension { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
