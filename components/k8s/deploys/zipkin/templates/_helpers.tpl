{{/* vim: set filetype=mustache: */}}
{{/*
Return the proper NGINX image name
*/}}
{{- define "zipkin.image" -}}
{{ include "common.images.image" (dict "imageRoot" .Values.image "global" .Values.global) }}
{{- end -}}

{{/*
Return the proper Prometheus metrics image name
*/}}
{{- define "zipkin.metrics.image" -}}
{{ include "common.images.image" (dict "imageRoot" .Values.metrics.image "global" .Values.global) }}
{{- end -}}

{{/*
Return the proper Docker Image Registry Secret Names
*/}}
{{- define "zipkin.imagePullSecrets" -}}
{{ include "common.images.pullSecrets" (dict "images" (list .Values.image .Values.metrics.image .Values.dependencies.image ) "global" .Values.global) }}
{{- end -}}

{{/*
Expand the name of the chart.
*/}}
{{- define "zipkin.pvc" -}}
{{- coalesce .Values.persistence.existingClaim (include "common.names.fullname" .) -}}
{{- end -}}

{{/*
Create the name of the service account to use
*/}}
{{- define "zipkin.serviceAccountName" -}}
{{- if .Values.serviceAccount.create -}}
    {{ default (include "common.names.fullname" .) .Values.serviceAccount.name }}
{{- else -}}
    {{ default "default" .Values.serviceAccount.name }}
{{- end -}}
{{- end -}}

{{/* Check if there are rolling tags in the images */}}
{{- define "zipkin.checkRollingTags" -}}
{{- include "common.warnings.rollingTag" .Values.image }}
{{- include "common.warnings.rollingTag" .Values.metrics.image }}
{{- include "common.warnings.rollingTag" .Values.volumePermissions.image }}
{{- end -}}

{{/*
Return the secret containing TLS certificates
*/}}
{{- define "zipkin.tlsSecretName" -}}
{{- $secretName := coalesce .Values.tls.existingSecret .Values.tls.secretName -}}
{{- if $secretName -}}
    {{- printf "%s" (tpl $secretName $) -}}
{{- else -}}
    {{- printf "%s-crt" (include "common.names.fullname" .) -}}
{{- end -}}
{{- end -}}

{{/*
Return true if a TLS secret object should be created
*/}}
{{- define "zipkin.createTlsSecret" -}}
{{- if and .Values.tls.enabled .Values.tls.autoGenerated (not .Values.tls.secretName) (not .Values.tls.existingSecret) }}
    {{- true -}}
{{- end -}}
{{- end -}}

{{/*
Create a default fully qualified app name.
We truncate at 63 chars because some Kubernetes name fields are limited to this (by the DNS naming spec).
*/}}
{{- define "zipkin.elasticsearch.fullname" -}}
{{- include "common.names.dependency.fullname" (dict "chartName" "elasticsearch" "chartValues" .Values.elasticsearch "context" $) -}}
{{- end -}}
