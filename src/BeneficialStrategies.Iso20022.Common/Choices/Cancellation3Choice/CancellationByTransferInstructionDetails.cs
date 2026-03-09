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
namespace BeneficialStrategies.Iso20022.Choices.Cancellation3Choice
{
    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_B6LRACcaEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CancellationByTransferInstructionDetails : Cancellation3Choice_
    #else
    public partial class CancellationByTransferInstructionDetails : Cancellation3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CancellationByTransferInstructionDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CancellationByTransferInstructionDetails( Account5 reqTransferorAccount,PartyIdentification2Choice_ reqTransferee )
        {
            TransferorAccount = reqTransferorAccount;
            Transferee = reqTransferee;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ82RgHEeKqWJINzXcn5g")]
        [DisplayName("Primary Individual Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmryIndvInvstr")]
        #endif
        [IsoXmlTag("PmryIndvInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
        #else
        public IndividualPerson8? PrimaryIndividualInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ83RgHEeKqWJINzXcn5g")]
        [DisplayName("Secondary Individual Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ScndryIndvInvstr")]
        #endif
        [IsoXmlTag("ScndryIndvInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
        #else
        public IndividualPerson8? SecondaryIndividualInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ84RgHEeKqWJINzXcn5g")]
        [DisplayName("Other Individual Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrIndvInvstr")]
        #endif
        [IsoXmlTag("OthrIndvInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IndividualPerson8? OtherIndividualInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public IndividualPerson8? OtherIndividualInvestor { get; init; } 
        #else
        public IndividualPerson8? OtherIndividualInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying the primary corporate investor, eg, name and address.
        /// </summary>
        [IsoId("_eJJ85RgHEeKqWJINzXcn5g")]
        [DisplayName("Primary Corporate Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmryCorpInvstr")]
        #endif
        [IsoXmlTag("PmryCorpInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Organisation4? PrimaryCorporateInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Organisation4? PrimaryCorporateInvestor { get; init; } 
        #else
        public Organisation4? PrimaryCorporateInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying the secondary corporate investor, eg, name and address.
        /// </summary>
        [IsoId("_eJJ86RgHEeKqWJINzXcn5g")]
        [DisplayName("Secondary Corporate Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ScndryCorpInvstr")]
        #endif
        [IsoXmlTag("ScndryCorpInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Organisation4? SecondaryCorporateInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Organisation4? SecondaryCorporateInvestor { get; init; } 
        #else
        public Organisation4? SecondaryCorporateInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying the other corporate investors, eg, name and address.
        /// </summary>
        [IsoId("_eJJ87RgHEeKqWJINzXcn5g")]
        [DisplayName("Other Corporate Investor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrCorpInvstr")]
        #endif
        [IsoXmlTag("OthrCorpInvstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Organisation4? OtherCorporateInvestor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Organisation4? OtherCorporateInvestor { get; init; } 
        #else
        public Organisation4? OtherCorporateInvestor { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of an account owned by the investor at the old plan manager (account servicer).
        /// </summary>
        [IsoId("_eJJ88RgHEeKqWJINzXcn5g")]
        [DisplayName("Transferor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfrAcct")]
        #endif
        [IsoXmlTag("TrfrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Account5 TransferorAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Account5 TransferorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Account5 TransferorAccount { get; init; } 
        #else
        public Account5 TransferorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
        /// </summary>
        [IsoId("_eJJ89RgHEeKqWJINzXcn5g")]
        [DisplayName("Nominee Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmneeAcct")]
        #endif
        [IsoXmlTag("NmneeAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Account6? NomineeAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Account6? NomineeAccount { get; init; } 
        #else
        public Account6? NomineeAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the institution to which the financial instrument is to be transferred.
        /// </summary>
        [IsoId("_eJJ8-RgHEeKqWJINzXcn5g")]
        [DisplayName("Transferee")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Trfee")]
        #endif
        [IsoXmlTag("Trfee")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification2Choice_ Transferee { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification2Choice_ Transferee { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_ Transferee { get; init; } 
        #else
        public PartyIdentification2Choice_ Transferee { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
        /// </summary>
        [IsoId("_eJJ8_RgHEeKqWJINzXcn5g")]
        [DisplayName("Cash Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshAcct")]
        #endif
        [IsoXmlTag("CshAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount11? CashAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount11? CashAccount { get; init; } 
        #else
        public CashAccount11? CashAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information related to the asset(s) transferred.
        /// </summary>
        [IsoId("_eJJ9ARgHEeKqWJINzXcn5g")]
        [DisplayName("Product Transfer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PdctTrf")]
        #endif
        [IsoXmlTag("PdctTrf")]
        public ValueList<ISATransfer8> ProductTransfer { get; init; } = new ValueList<ISATransfer8>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _eJJ9ARgHEeKqWJINzXcn5g
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_eJJ9BRgHEeKqWJINzXcn5g")]
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
