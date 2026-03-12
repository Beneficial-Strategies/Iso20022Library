// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitIdentification1Choice
{
    /// <summary>
    /// Identification of all current limits.
    /// </summary>
    [IsoId("_73kl0qMgEeCJ6YNENx4h-w_1435254902")]
    [DisplayName("All Current")]
    public partial record AllCurrent : LimitIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_79Y59KMgEeCJ6YNENx4h-w_1467741043")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        
        /// <summary>
        /// Nature of the risk management limit.
        /// </summary>
        [IsoId("_79Y59aMgEeCJ6YNENx4h-w_-939946563")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required LimitType1Choice_ Type { get; init; } 
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_79Y59qMgEeCJ6YNENx4h-w_1519150628")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_79Y596MgEeCJ6YNENx4h-w_-938620996")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
