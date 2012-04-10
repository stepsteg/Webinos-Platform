﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 04 March 2010 22:59:06
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using policyDB;
using policyDB.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace policyDB.FactoryClasses
{
	/// <summary>
	/// Generates IEntityFields instances for different kind of Entities. 
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class EntityFieldsFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldsFactory()
		{
		}


		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateEntityFieldsObject(policyDB.EntityType relatedEntityType)
		{
			IEntityFields fieldsToReturn=null;
			IInheritanceInfoProvider inheritanceProvider = InheritanceInfoProviderSingleton.GetInstance();
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(relatedEntityType)
			{
				case policyDB.EntityType.AttributeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "AttributeEntity");
					break;
				case policyDB.EntityType.AttributeTypeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "AttributeTypeEntity");
					break;
				case policyDB.EntityType.AttributeValueEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "AttributeValueEntity");
					break;
				case policyDB.EntityType.CombineModeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CombineModeEntity");
					break;
				case policyDB.EntityType.ContextEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "ContextEntity");
					break;
				case policyDB.EntityType.DecisionNodeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "DecisionNodeEntity");
					break;
				case policyDB.EntityType.EffectEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "EffectEntity");
					break;
				case policyDB.EntityType.LibraryEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "LibraryEntity");
					break;
				case policyDB.EntityType.PolicyEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "PolicyEntity");
					break;
				case policyDB.EntityType.PolicyDocumentEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "PolicyDocumentEntity");
					break;
				case policyDB.EntityType.PolicyLinkEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "PolicyLinkEntity");
					break;
				case policyDB.EntityType.QueryEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "QueryEntity");
					break;
				case policyDB.EntityType.QueryValueEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "QueryValueEntity");
					break;
				case policyDB.EntityType.RuleEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "RuleEntity");
					break;
				case policyDB.EntityType.TargetEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "TargetEntity");
					break;
				case policyDB.EntityType.TargetConditionEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "TargetConditionEntity");
					break;
				case policyDB.EntityType.UriComponentEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "UriComponentEntity");
					break;
			}
			return fieldsToReturn;
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			return fieldProvider.GetEntityFieldsArray(entityName, persistenceProvider);
		}



		#region Included Code

		#endregion
	}
}
