﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Profio.Domain.Constants;
using Profio.Domain.Entities;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Profio.Infrastructure.Persistence.Optimization
{
    internal partial class IncidentEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Profio.Domain.Entities.Incident",
                typeof(Incident),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(string),
                propertyInfo: typeof(Incident).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 26);

            var deliveryId = runtimeEntityType.AddProperty(
                "DeliveryId",
                typeof(string),
                propertyInfo: typeof(Incident).GetProperty("DeliveryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<DeliveryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(Incident).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250,
                unicode: true);

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(IncidentStatus),
                propertyInfo: typeof(Incident).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var time = runtimeEntityType.AddProperty(
                "Time",
                typeof(DateTime?),
                propertyInfo: typeof(Incident).GetProperty("Time", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<Time>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { deliveryId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DeliveryId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.SetNull);

            var delivery = declaringEntityType.AddNavigation("Delivery",
                runtimeForeignKey,
                onDependent: true,
                typeof(Delivery),
                propertyInfo: typeof(Incident).GetProperty("Delivery", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Incident).GetField("<Delivery>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var incidents = principalEntityType.AddNavigation("Incidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Incident>),
                propertyInfo: typeof(Delivery).GetProperty("Incidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Delivery).GetField("<Incidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Incidents");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
