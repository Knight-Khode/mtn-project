const signinForm = async (e) => {
    e.preventDefault();
    let data = new FormData();

    function cleanUpForm() {
        document.getElementById("login-username").value = "";
        document.getElementById("login-password").value = "";
    }

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-top-center",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    if (!document.getElementById("login-password").value.trim()) {
        return toastr.error('Password field Cannot be Empty')
    }
    if (!document.getElementById("login-username").value.trim() || document.getElementById("login-username").value.length < 5 ) {
        return toastr.error('Username field is invalid')
    }

    data.append('Username', document.getElementById("login-userName").value);
    data.append('Password', document.getElementById("login-password").value);

    try {
        const response = await fetch('/api/user/submit/signin', {
            method: 'POST',
            body: data
        });
        console.log(data);

        if (response.status === 200) {
            cleanUpForm();

            toastr["success"]("Successfully SignedUp")
        }
        else {
            //Comment//
        }
    }
    catch (error) {
        console.log({ error });
    }

};

const form = document.getElementById("loginForm");
form.addEventListener("click", signinForm);
