const signupForm = async (e) => {
    e.preventDefault();
    let data = new FormData();

    function cleanUpForm() {
        document.getElementById("fullName").value = "";
        document.getElementById("userName").value = "";
        document.getElementById("phoneNumber").value = "";
        document.getElementById("email").value = "";
        document.getElementById("password").value = "";
        document.getElementById("confirmPassword").value = "";
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
    if (!document.getElementById("fullName").value.trim()) {
        return toastr.error('Full Name field Cannot be Empty')
    }
    if (!document.getElementById("userName").value.trim()) {
        return toastr.error('UserName field Cannot be Empty')
    }
    if (document.getElementById("userName").value.length < 5 ) {
        return toastr.error('UserName field Cannot be less than 5 characters')
    }
    if (!document.getElementById("phoneNumber").value.trim()) {
        return toastr.error('Phone Number field Cannot be Empty')
    }
    if (!document.getElementById("password").value.trim()) {
        return toastr.error('Password  field Cannot be Empty')
    }
    if (!document.getElementById("confirmPassword").value.trim()) {
        return toastr.error('Confirm Password field Cannot be Empty')
    }
    if (document.getElementById("confirmPassword").value !== document.getElementById("password").value) {
        return toastr.error('Password doesnot match')
    }

    data.append('FullName', document.getElementById("fullName").value);
    data.append('Username', document.getElementById("userName").value);
    data.append('PhoneNumber', document.getElementById("phoneNumber").value);
    data.append('Email', document.getElementById("email").value);
    data.append('Password', document.getElementById("password").value);
    data.append('ConfirmPassword', document.getElementById("confirmPassword").value);

    try {
        const response = await fetch('/api/user/submit/register', {
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

const form = document.getElementById("registrationForm");
form.addEventListener("click", signupForm);
