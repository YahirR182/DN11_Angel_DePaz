document.addEventListener('DOMContentLoaded', function () {
    var identificadorInput = document.getElementById('identificador');
    var registrarBtn = document.querySelector('.btn-primary');

    identificadorInput.addEventListener('keydown', function (event) {
        if (event.key === 'Enter') {
            manejarRegistro(registrarBtn.getAttribute('data-tipo-registro'));
        }
    });

    registrarBtn.addEventListener('click', function () {
        manejarRegistro(registrarBtn.getAttribute('data-tipo-registro'));
    });

    function manejarRegistro(tipoRegistro) {
        if (identificadorInput.value.trim() === '') {
            alert('Por favor, ingrese un identificador antes de continuar.');
        } else {
            var identificador = identificadorInput.value.trim();
            var horaActual = obtenerHoraActual();
            var mensaje = tipoRegistro.charAt(0).toUpperCase() + tipoRegistro.slice(1) + ' registrada para el miembro ' + identificador + ' a las ' + horaActual;

            abrirModal(mensaje);

            setTimeout(function () {
                if (!document.querySelector('.modal')) {
                    return;
                }

                modal.remove();
            }, 3000);
        }
    }

    function obtenerHoraActual() {
        var now = new Date();
        var horas = now.getHours();
        var minutos = now.getMinutes();
        minutos = minutos < 10 ? '0' + minutos : minutos;
        return horas + ':' + minutos;
    }

    function abrirModal(mensaje) {
        var modalHTML = '<div class="modal" tabindex="-1">';
        modalHTML += '<div class="modal-dialog">';
        modalHTML += '<div class="modal-content">';
        modalHTML += '<div class="modal-header">';
        modalHTML += '<h5 class="modal-title">Registro Exitoso</h5>';
        modalHTML += '<button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>';
        modalHTML += '</div>';
        modalHTML += '<div class="modal-body">';
        modalHTML += '<p>' + mensaje + '</p>';
        modalHTML += '</div>';
        modalHTML += '<div class="modal-footer">';
        modalHTML += '</div>';
        modalHTML += '</div>';
        modalHTML += '</div>';
        modalHTML += '</div>';

        document.body.insertAdjacentHTML('beforeend', modalHTML);

        var modal = document.querySelector('.modal');
        var modalInstance = new bootstrap.Modal(modal);
        modalInstance.show();

        modal.addEventListener('hidden.bs.modal', function () {
            if (!document.querySelector('.modal')) {
                return;
            }

            modalInstance.hide();
        });
    }
});
